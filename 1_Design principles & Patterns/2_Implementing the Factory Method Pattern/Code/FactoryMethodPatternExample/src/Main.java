import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        DocumentFactory factory = new DocumentFactory();

        System.out.print("Enter document type (WORD / EXCEL): ");
        String type = sc.nextLine();

        DocumentFactory.createDocument(type);  // done!
    }
}