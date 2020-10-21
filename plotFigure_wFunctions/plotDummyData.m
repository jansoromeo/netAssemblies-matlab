function plotDummyData()
hfig = findall(0,'Type','figure','tag','FigureStateSpace'); 
hax = findall(hfig,'Type','Axes','tag','StateSpaceAxes'); 
if ~isempty(hax)
    cla(hax);
    xvals = randperm(10,10);
    yvals = randperm(10,10);
    PlotData(xvals,yvals);
end
end