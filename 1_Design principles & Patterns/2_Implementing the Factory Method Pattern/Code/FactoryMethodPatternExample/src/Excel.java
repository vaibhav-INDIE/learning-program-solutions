import java.util.Arrays;
import java.util.Scanner;

public class Excel implements Document {
    private String title;
    private String[][] table;


    @Override
    public void create() {
        System.out.println("Making Excel document");
    }

    @Override
    public void initialize() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter title for Excel document: ");
        this.title = sc.nextLine();

        System.out.print("Enter number of rows: ");
        int rows = sc.nextInt();
        System.out.print("Enter number of columns: ");
        int cols = sc.nextInt();
        sc.nextLine();

        this.table = new String[rows][cols];
        for (int i = 0; i < rows; i++) {
            System.out.println("Enter row " + (i + 1) + " (space-separated): ");
            String[] values = sc.nextLine().split(" ");
            System.arraycopy(values, 0, table[i], 0, Math.min(cols, values.length));
        }


    }

    @Override
    public void show(){
        System.out.print(title);
        System.out.print(Arrays.deepToString(table));
    }
}
