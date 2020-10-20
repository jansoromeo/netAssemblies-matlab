/*
 * MATLAB Compiler: 8.1 (R2020b)
 * Date: Tue Oct 20 12:42:33 2020
 * Arguments:
 * "-B""macro_default""-W""lib:PlotFigure,version=1.0""-T""link:lib""-d""\\Mac\H
 * ome\Dropbox
 * (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigureUsingClass\PlotFigure
 * \for_testing""-v""\\Mac\Home\Dropbox
 * (Personal)\Work\Git_Repo\netAssemblies-matlab\plotFigureUsingClass\PlotFigure
 * .m"
 */

#ifndef PlotFigure_h
#define PlotFigure_h 1

#if defined(__cplusplus) && !defined(mclmcrrt_h) && defined(__linux__)
#  pragma implementation "mclmcrrt.h"
#endif
#include "mclmcrrt.h"
#ifdef __cplusplus
extern "C" { // sbcheck:ok:extern_c
#endif

/* This symbol is defined in shared libraries. Define it here
 * (to nothing) in case this isn't a shared library. 
 */
#ifndef LIB_PlotFigure_C_API 
#define LIB_PlotFigure_C_API /* No special import/export declaration */
#endif

/* GENERAL LIBRARY FUNCTIONS -- START */

extern LIB_PlotFigure_C_API 
bool MW_CALL_CONV PlotFigureInitializeWithHandlers(
       mclOutputHandlerFcn error_handler, 
       mclOutputHandlerFcn print_handler);

extern LIB_PlotFigure_C_API 
bool MW_CALL_CONV PlotFigureInitialize(void);

extern LIB_PlotFigure_C_API 
void MW_CALL_CONV PlotFigureTerminate(void);

extern LIB_PlotFigure_C_API 
void MW_CALL_CONV PlotFigurePrintStackTrace(void);

/* GENERAL LIBRARY FUNCTIONS -- END */

/* C INTERFACE -- MLX WRAPPERS FOR USER-DEFINED MATLAB FUNCTIONS -- START */

extern LIB_PlotFigure_C_API 
bool MW_CALL_CONV mlxPlotFigure(int nlhs, mxArray *plhs[], int nrhs, mxArray *prhs[]);

/* C INTERFACE -- MLX WRAPPERS FOR USER-DEFINED MATLAB FUNCTIONS -- END */

/* C INTERFACE -- MLF WRAPPERS FOR USER-DEFINED MATLAB FUNCTIONS -- START */

extern LIB_PlotFigure_C_API bool MW_CALL_CONV mlfPlotFigure(int nargout, mxArray** varargout, mxArray* varargin);

#ifdef __cplusplus
}
#endif
/* C INTERFACE -- MLF WRAPPERS FOR USER-DEFINED MATLAB FUNCTIONS -- END */

#endif
