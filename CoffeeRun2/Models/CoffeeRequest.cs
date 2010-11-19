namespace Enzo.CoffeeRun2.Web.Models
{
    public class CoffeeRequest
    {
        public CoffeeRequest()
        {
            Coffee = Coffee.Cappacino;
        }

        public Coffee Coffee { get; set; }
    }
}