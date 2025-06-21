import java.util.Scanner;

public class Word implements Document {
    private String Title;
    private String Content;

    @Override
    public void create() {
        System.out.println("Opening Word document...");
    }

    @Override
    public void initialize() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter title for Word document: ");
        this.Title = sc.nextLine();
        System.out.print("Enter content for Word document: ");
        this.Content = sc.nextLine();
    }

    @Override
    public void show(){
        System.out.println(Title);
        System.out.println("\n  \n" + Content);
    }

}
