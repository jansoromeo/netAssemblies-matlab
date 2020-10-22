/*
* MATLAB Compiler: 8.1 (R2020b)
* Date: Thu Oct 22 15:35:00 2020
* Arguments:
* "-B""macro_default""-W""dotnet:PlotFigure_wFunctionsCom,Class1,4.0,private,version=1.1""
* -T""link:lib""-d""\\Mac\Home\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\PlotFigure_wFunction
* sCom\for_testing""-v""class{Class1:\\Mac\Home\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\getLineCoordinates.m
* ,\\Mac\Home\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\HideFigure.m,\\Mac\H
* ome\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\InitFigure.m,\\Mac\H
* ome\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\PlotData.m,\\Mac\Hom
* e\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\plotDummyData.m,\\Ma
* c\Home\Dropbox
* (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\ShowFigure.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace PlotFigure_wFunctionsCom
{

  /// <summary>
  /// The Class1 class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox
  /// (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\getLineCoordinat
  /// es.m
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox
  /// (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\HideFigure.m
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox
  /// (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\InitFigure.m
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox
  /// (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\PlotData.m
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox
  /// (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\plotDummyData.m
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox
  /// (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigure_wFunctions\ShowFigure.m
  /// </summary>
  /// <remarks>
  /// @Version 1.1
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
    /// Provides a single output, 0-input MWArrayinterface to the getLineCoordinates
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray getLineCoordinates()
    {
      return mcr.EvaluateFunction("getLineCoordinates", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the getLineCoordinates MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] getLineCoordinates(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "getLineCoordinates", new MWArray[]{});
    }


    /// <summary>
    /// Provides an interface for the getLineCoordinates function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void getLineCoordinates(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                         argsIn)
    {
      mcr.EvaluateFunction("getLineCoordinates", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the HideFigure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void HideFigure()
    {
      mcr.EvaluateFunction(0, "HideFigure", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the HideFigure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] HideFigure(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "HideFigure", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the InitFigure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// close and clean up previous figures 
    /// </remarks>
    ///
    public void InitFigure()
    {
      mcr.EvaluateFunction(0, "InitFigure", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the InitFigure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// close and clean up previous figures 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] InitFigure(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "InitFigure", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void PlotData()
    {
      mcr.EvaluateFunction(0, "PlotData", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void PlotData(MWArray x)
    {
      mcr.EvaluateFunction(0, "PlotData", x);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void PlotData(MWArray x, MWArray y)
    {
      mcr.EvaluateFunction(0, "PlotData", x, y);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotData(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotData", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotData(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotData", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PlotData MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotData(int numArgsOut, MWArray x, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotData", x, y);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the plotDummyData MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void plotDummyData()
    {
      mcr.EvaluateFunction(0, "plotDummyData", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the plotDummyData MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] plotDummyData(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "plotDummyData", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the ShowFigure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void ShowFigure()
    {
      mcr.EvaluateFunction(0, "ShowFigure", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the ShowFigure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ShowFigure(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "ShowFigure", new MWArray[]{});
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
