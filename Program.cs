// NOTE: found out that using identical startup class symbols breaks the 
// `-p:StartupObject=<namespace>.<class>` method of running
namespace HelloWorld {
  class HelloWorld {
    static void Main(string[] args) {
      // Hello world example
      Console.WriteLine("Hello, World!");
    }
  }
}

namespace Variables {
  class Variables {
    static void Main(string[] args) {
      Console.WriteLine("===W3 Schools Variables===");

      Console.WriteLine("Name Example:");
      string name = "Isaac Spiegel";
      Console.WriteLine(name);

      Console.WriteLine("Int Example:");
      int age = 22;
      Console.WriteLine(age);

      Console.WriteLine("Int Declare-First Example:");
      int numberOfCatsOwned;
      numberOfCatsOwned = 2;
      Console.WriteLine(numberOfCatsOwned);

      Console.WriteLine("Int Re-Assign Example:");
      int numberOfDogsOwned = 2;
      numberOfDogsOwned = 0;
      Console.WriteLine(numberOfDogsOwned);

      Console.WriteLine("Other Primitive Types Example:");
      double myDoubleNum = 5.99D;
      char myLetter = 'D';
      bool correct = true;
      Console.WriteLine(myDoubleNum);
      Console.WriteLine(myLetter);
      Console.WriteLine(correct);
    }
  }
}

namespace Constants {
  class Constants {
    static void Main(string[] args) {
      const int myNum = 14;
      myNum = 20; // Error
    }
  }
}