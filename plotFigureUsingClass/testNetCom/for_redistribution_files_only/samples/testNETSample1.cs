using System;
using System.Collections.Generic;
using System.Text;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using testNetCom;

/// <summary>
/// Sample driver code that integrates a compiled MATLAB function
/// generated by MATLAB Compiler SDK
///
/// Refer to the MATLAB Compiler SDK documentation for more
/// information.
/// </summary>
class testNETSample1 {

	static Class1 class1Instance;

	static void Setup() {
		class1Instance = new Class1();
	}

	/// <summary>
	/// Example of using the testNET function.
	/// </summary>
	public static void TestNETSample() {
		Object[] results = null;
		try {
			results = class1Instance.testNET();
		} catch (Exception e) {
			Console.WriteLine(e);
		}
	}

	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	static void Main(string[] args) {
		try {
			Setup();
		} catch (Exception e) {
			Console.WriteLine(e);
			Environment.Exit(1);
		}
		try {
			TestNETSample();
		} catch (Exception e) {
			Console.WriteLine(e);
			Environment.Exit(1);
		}
	}

}