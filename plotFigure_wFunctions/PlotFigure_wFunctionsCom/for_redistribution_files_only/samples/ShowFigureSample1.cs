using System;
using System.Collections.Generic;
using System.Text;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using PlotFigure_wFunctionsCom;

/// <summary>
/// Sample driver code that integrates a compiled MATLAB function
/// generated by MATLAB Compiler SDK
///
/// Refer to the MATLAB Compiler SDK documentation for more
/// information.
/// </summary>
class ShowFigureSample1 {

	static Class1 class1Instance;

	static void Setup() {
		class1Instance = new Class1();
	}

	/// <summary>
	/// Example of using the ShowFigure function.
	/// </summary>
	public static void ShowFigureSample() {
		Object[] results = null;
		try {
			results = class1Instance.ShowFigure();
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
			ShowFigureSample();
		} catch (Exception e) {
			Console.WriteLine(e);
			Environment.Exit(1);
		}
	}

}