import org.junit.jupiter.api.Test;
import java.util.concurrent.*;
import static org.junit.jupiter.api.Assertions.*;

public class Tester {
    @Test
    public void testSingletonInstance() {
        Logger logger1 = Logger.getlogger();
        Logger logger2 = Logger.getlogger();
        assertSame(logger1, logger2, "Different logger referenced. ");
    }

    @Test
    public void testLoggerNotNull() {
        Logger logger = Logger.getlogger();
        assertNotNull(logger, "Logger instance should not be null");
    }

    @Test
    public void testLoggerOutput() {
        Logger logger = Logger.getlogger();
        assertDoesNotThrow(() -> logger.log("Testing Logger output"), "Logging should not throw exception");
    }

    @Test
    public void testThreadSafetySingleton() throws InterruptedException, ExecutionException {
        Callable<Logger> task = () -> Logger.getlogger();

        int threads = 10;
        ExecutorService executor = Executors.newFixedThreadPool(threads);
        Future<Logger>[] futures = new Future[threads];

        for (int i = 0; i < threads; i++) {
            futures[i] = executor.submit(task);
        }

        Logger firstInstance = futures[0].get();
        for (int i = 1; i < threads; i++) {
            assertSame(firstInstance, futures[i].get(), "All threads should get the same Logger instance");
        }

        executor.shutdown();
    }
}
