public class DocumentFactory {
    public static Document createDocument(String type) {
        if (type.equalsIgnoreCase("WORD")) {
            Word word = new Word();
            word.create();
            word.initialize();
            word.show();
        } else if (type.equalsIgnoreCase("EXCEL")) {
            Excel excel = new Excel();
            excel.create();
            excel.initialize();
            excel.show();
        }
        return null;
    }
}
