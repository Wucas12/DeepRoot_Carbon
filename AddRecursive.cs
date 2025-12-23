public class AddRecursive{
  public static void Main(string[] args){
    Console.WriteLine(Add(2,5));
    Console.WriteLine(Add(-2,5));
  }

  public static int Add(int n1, int n2){
    if (n2 == 0){
      return n1;
    }
    else if (n2 > 0){
      n1++;
      n2--;
      return Add(n1, n2);
    }
    else{
      n1--;
      n2++;
      return Add(n1,n2);
    }
  }
}
