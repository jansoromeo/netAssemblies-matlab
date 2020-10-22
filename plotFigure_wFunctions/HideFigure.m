function HideFigure()
hfig = findall(0,'Type','figure','tag','FigureStateSpace');
if ~isempty(hfig)
    hfig.Visible = 'off';
end
end