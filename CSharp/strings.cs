   public static string[] strNum0To19= { "zero","one","two","three","four","five","six","seven","eight","nine",
       "ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen" };
   public static string[] strNum1To9 = strNum0To19.Skip(1).Take(9).ToArray();
   public static string[] hours = strNum0To19.Skip(1).Take(12).Prepend("midnight").ToArray();
   public static string [] strTens0To9 = {"","ten","twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninety"};
