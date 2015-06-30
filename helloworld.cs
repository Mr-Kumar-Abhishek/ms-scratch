using System;

class HelloWorld {
	static void Main() {
#if DebugConfig
		Console.WriteLine("We are in debug configuration");
#endif
		Console.WriteLine("Hello, World!");
	}
}

