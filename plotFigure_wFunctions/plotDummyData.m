function plotDummyData(varargin)
hfig = findall(0,'Type','figure','tag','FigureStateSpace'); 
hax = findall(hfig,'Type','Axes','tag','StateSpaceAxes'); 
cla(hax);
xvals = randperm(10,10);
yvals = randperm(10,10);
PlotData(xvals,yvals);
end