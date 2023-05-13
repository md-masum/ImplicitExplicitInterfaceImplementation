namespace ImplicitExplicitInterface
{
    public interface IOrder
    {
        void Delete();
    }
    public interface ICart
    {
        void Delete();
        void Add();
    }

    public class ProductService : IOrder, ICart
    {
        public void Delete()                //Implicit interface implementation 
        {
            Console.WriteLine("deleted");
        }

        void IOrder.Delete()                //Explicit interface implementation 
        {
            Console.WriteLine("order deleted");
        }

        void ICart.Delete()                 //Explicit interface implementation 
        {
            Console.WriteLine("cart deleted");
        }

        public void Add()                   //Implicit interface implementation 
        {
            Console.WriteLine("added");
        }

        void ICart.Add()                    //Explicit interface implementation 
        {
            Console.WriteLine("cart added");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var productObj = new ProductService();          // Add and delete function available here
            productObj.Delete(); 
            productObj.Add();

            var orderInterfaceObj = (IOrder)productObj;     // only IOrder interface member available here
            orderInterfaceObj.Delete();

            var cardInterfaceObj = (ICart)productObj;       // only ICart interface member available here
            cardInterfaceObj.Delete();
            cardInterfaceObj.Add();
        }
    }
}