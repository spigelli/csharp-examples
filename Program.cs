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
      // const int myNum = 14;
      // myNum = 20; // Error
    }
  }
}

namespace DisplayVariables {
  class DisplayVariables {
    static void Main(string[] args) {
      Console.WriteLine("===W3 Schools Display Variables===");
      Console.WriteLine("String concatenation example:");
      string name = "Isaac Spiegel";
      Console.WriteLine("My name is " + name);
    }
  }
}

namespace MultipleVariables {
  class MultipleVariables {
    static void Main(string[] args) {
      Console.WriteLine("===W3 Schools Declare Many Variables===");
      int x = 5, y = 6, z = 50;
      Console.WriteLine(x + y + z);
    }
  }
}

namespace DataTypes {
  class DataTypes {
    static void log(string input) {
      Console.WriteLine(input);
    }

    static void Main(string[] args) {
      log("===W3 Schools DataTypes===");
      log("Integers:");
      log("\tSize: 4 bytes");
      log("\t~Range: -2,147,000,000 - 2,147,000,000\n");

      log("Long:");
      log("\tSize: 8 bytes");
      log("\t~Range: -9,228,000,000,000,000 - 9,228,000,000,000,000\n");

      log("Float:");
      log("\tSize: 4 bytes");
      log("\t~Range: 6-7 decimal places\n");

      log("Double:");
      log("\tSize: 8 bytes");
      log("\t~Range: 15 decimal places\n");

      log("Bool");
      log("\tSize: 1 bit");

      log("Char");
      log("\tSize: 2 bytes");

      log("String");
      log("\tSize: 2 bytes per character");
    }
  }
}