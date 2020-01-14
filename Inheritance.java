class SQL{
    protected SQL(){
        System.out.print("Intializing queries to create ");
    }
    protected void create(){
        System.err.println("Creating Table.");
    }
    protected void delete(){
        System.out.println("Deleting Table.");
    }
    protected void update() {
        System.out.println("Updating Table.");
    }
}
class Oracle extends SQL{
    public Oracle(){
        super();
        System.out.println("Oracle Database.");
    }
    public void update(){
        System.out.println("Updating Table using Oracle query.");
    }
    public void ROWNUM(){
        System.out.println("Query to return TOP 'X' number of rows.");
    }
 
}
class SQLSERVER extends SQL{
    public SQLSERVER(){
        super();
        System.out.println("SQLSERVER Database.");
    }
    public void update(){
        System.out.println("Updating Table using SQLSERVER query.");
    }
    public void TOP(){
        System.out.println("Query to return TOP 'X' number of rows.");
    }
}
public class Inheritance{
    public static void main(String args[]) {
        System.out.println("Implementation of Inheritance.");
        Oracle oracle =new Oracle();
        oracle.create();
        oracle.update();
        oracle.ROWNUM();
        SQLSERVER sqlserver =new SQLSERVER();
        sqlserver.create();
        sqlserver.update();
        sqlserver.TOP();
    }
}
