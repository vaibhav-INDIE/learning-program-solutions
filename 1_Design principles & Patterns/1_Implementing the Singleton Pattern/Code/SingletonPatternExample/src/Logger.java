public class Logger {
    private static volatile Logger instance;


    private Logger() {

    }
    public static Logger getlogger(){
        if(instance==null){
            synchronized(Logger.class){
                if(instance==null){
                    instance = new Logger();
                }
            }
        }
        return instance;
    }
    public void log(String message) {
        System.out.println("[Logger] " + message);
    }
}
