  public static int SignOf(int value) => value<0 ? -1 : 1;
  public static int AWithSignOfB(int a, int b) => Math.Abs(a)*SignOf(b);
