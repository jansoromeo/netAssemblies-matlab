/*
* MATLAB Compiler: 8.1 (R2020b)
* Date: Wed Oct 21 15:24:05 2020
* Arguments:
* "-B""macro_default""-W""dotnet:PlotFigure_wFunctionsCom,Class1,4.0,private,version=1.0""
* -T""link:lib""-d""\\Mac\Home\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\PlotFigure_wFunction
* sCom\for_testing""-v""class{Class1:\\Mac\Home\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\getLineCoordinates.m
* ,\\Mac\Home\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\InitFigure.m,\\Mac\H
* ome\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\PlotData.m,\\Mac\Hom
* e\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\plotDummyData.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace PlotFigure_wFunctionsComNative
{

  /// <summary>
  /// The Class1 class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox
  /// (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\getLineCoordinat
  /// es.m
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox
  /// (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\InitFigure.m
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox
  /// (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\PlotData.m
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox
  /// (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\plotDummyData.m
  /// </summary>
  /// <remarks>
  /// @Version 1.0
  /// </remarks>
  public class Class1 : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static Class1()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

		  int lastDelimiter = ctfFilePath.LastIndexOf(@"/");

	      if (lastDelimiter == -1)
		  {
		    lastDelimiter = ctfFilePath.LastIndexOf(@"\");
		  }

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "PlotFigure_wFunctionsCom.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Class1 class.
    /// </summary>
    public Class1()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Class1()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the getLineCoordinates
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object getLineCoordinates()
    {
      return mcr.EvaluateFunction("getLineCoordinates", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the getLineCoordinates MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] getLineCoordinates(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "getLineCoordinates", new Object[]{});
    }


    /// <summary>
    /// Provides an interface for the getLineCoordinates function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("getLineCoordinates", 0, 1, 0)]
    protected void getLineCoordinates(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("getLineCoordinates", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the InitFigure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// close and clean up previous figures 
    /// </remarks>
    ///
    public void InitFigure()
    {
      mcr.EvaluateFunction(0, "InitFigure", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the InitFigure MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// close and clean up previous figures 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] InitFigure(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "InitFigure", new Object[]{});
    }


    /// <summary>
    /// Provides an interface for the InitFigure function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// close and clean up previous figures 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("InitFigure", 0, 0, 0)]
    protected void InitFigure(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("InitFigure", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void PlotData()
    {
      mcr.EvaluateFunction(0, "PlotData", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void PlotData(Object x)
    {
      mcr.EvaluateFunction(0, "PlotData", x);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void PlotData(Object x, Object y)
    {
      mcr.EvaluateFunction(0, "PlotData", x, y);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PlotData(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotData", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PlotData(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotData", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PlotData(int numArgsOut, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotData", x, y);
    }


    /// <summary>
    /// Provides an interface for the PlotData function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("PlotData", 2, 0, 0)]
    protected void PlotData(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("PlotData", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the plotDummyData MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void plotDummyData()
    {
      mcr.EvaluateFunction(0, "plotDummyData", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the plotDummyData MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] plotDummyData(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "plotDummyData", new Object[]{});
    }


    /// <summary>
    /// Provides an interface for the plotDummyData function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("plotDummyData", 0, 0, 0)]
    protected void plotDummyData(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("plotDummyData", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
