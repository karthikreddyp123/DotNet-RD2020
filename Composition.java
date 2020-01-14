class Product{
    private int id;
    private String name;
    
    public Product(int id, String name){
        this.id=id;
        this.name=name;
    }
    public int getId() {
        return this.id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        this.name = name;
    }

}
class Order{
    private Product product;
    public Order(int id,String name){
        product=new Product(id,name);
    }
    public void OrderDetails(){
        System.out.println("Order created for product:"+product.getName());
    }
}
public class Composition{
    public static void main(String args[]) {
        Order o=new Order(1,"Apple");
        o.OrderDetails();
    }
}