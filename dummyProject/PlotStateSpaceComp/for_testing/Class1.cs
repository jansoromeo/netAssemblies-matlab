/*
* MATLAB Compiler: 8.1 (R2020b)
* Date: Tue Oct 13 14:19:29 2020
* Arguments:
* "-B""macro_default""-W""dotnet:PlotStateSpaceComp,Class1,4.0,private,version=0.1""-T""li
* nk:lib""-d""\\Mac\Home\Dropbox
* (Personal)\Work\Git_Repo\temp\PlotStateSpaceComp\for_testing""-v""class{Class1:\\Mac\Hom
* e\Dropbox (Personal)\Work\Git_Repo\temp\plot_state_space.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace PlotStateSpaceComp
{

  /// <summary>
  /// The Class1 class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// \\Mac\Home\Dropbox (Personal)\Work\Git_Repo\temp\plot_state_space.m
  /// </summary>
  /// <remarks>
  /// @Version 0.1
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

          string ctfFileName = "PlotStateSpaceComp.ctf";

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
    /// Provides a void output, 0-input MWArrayinterface to the plot_state_space MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// plots two power bands
    /// inputs:
    /// x: power band 1
    /// y: power band 2
    /// </remarks>
    ///
    public void plot_state_space()
    {
      mcr.EvaluateFunction(0, "plot_state_space", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the plot_state_space MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// plots two power bands
    /// inputs:
    /// x: power band 1
    /// y: power band 2
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void plot_state_space(MWArray x)
    {
      mcr.EvaluateFunction(0, "plot_state_space", x);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the plot_state_space MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// plots two power bands
    /// inputs:
    /// x: power band 1
    /// y: power band 2
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void plot_state_space(MWArray x, MWArray y)
    {
      mcr.EvaluateFunction(0, "plot_state_space", x, y);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the plot_state_space MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// plots two power bands
    /// inputs:
    /// x: power band 1
    /// y: power band 2
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] plot_state_space(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "plot_state_space", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the plot_state_space MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// plots two power bands
    /// inputs:
    /// x: power band 1
    /// y: power band 2
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] plot_state_space(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "plot_state_space", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the plot_state_space MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// plots two power bands
    /// inputs:
    /// x: power band 1
    /// y: power band 2
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] plot_state_space(int numArgsOut, MWArray x, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "plot_state_space", x, y);
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
