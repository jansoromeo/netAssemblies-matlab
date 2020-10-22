function ShowFigure()
hfig = findall(0,'Type','figure','tag','FigureStateSpace');
if ~isempty(hfig)
    hfig.Visible = 'on';
end
end