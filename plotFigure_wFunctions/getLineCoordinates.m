function [cords] = getLineCoordinates()
hLine = findall(0,'Type','images.roi.line','tag','ThresholdLine'); 
if isempty(hLine)
    cords = [];
else
     cords = hLine.Position;
end
end