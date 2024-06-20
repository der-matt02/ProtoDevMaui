namespace ProtoDevMaui.Models
{
    public class Offer
    { 
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public Color BgColor { get; set; }

        public Offer(string title, string description,Color bgColor, string code)
        {
            Title = title;
            Description = description;
            BgColor = bgColor;
            Code = code;
        }

        private static readonly string[] _lightColors = new string[]
        {
            "#A8E6CF", "#85C1A4", "ffff00", "#FFD700", "#FF6F61", "#7fbdc7", "#ea978d"
        };
        private static Color RandomColor => Color.FromHex(_lightColors.OrderBy(c => Guid.NewGuid()).First());

        public static IEnumerable<Offer> GetOffers()
        {
            yield return new Offer("20% de Descuento", "Disfruta el 20% de Decuento en Componentes Electrónicos", RandomColor, "PATAS20");
            yield return new Offer("25% de Descuento", "Disfruta el 25% de Decuento en las Placas de Desarrollo Arduino", RandomColor, "ARD25");
            yield return new Offer("30$ de Descuento", "Disfruta el 30% de Decuento en las Placas de Desarrollo ESP", RandomColor, "ESP30");
            yield return new Offer("50% de Descuento", "Disfruta el 50% de Decuento en Jumpers y Cables Dupont", RandomColor, "JUMP50"); 
        }
    }
}
