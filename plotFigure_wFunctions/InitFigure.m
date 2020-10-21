function InitFigure()
% close and clean up previous figures 
close all force; 

%  setup up figure
hfig = uifigure('Tag','FigureStateSpace'); % use tags to find figure in other functions 
hfig.Color = 'w';
% set up axis
hax = axes('Parent',hfig,'Tag','StateSpaceAxes');  % use tags to find axes in other functions 
title(hax, 'Title')
xlabel(hax, 'X')
ylabel(hax, 'Y')
hax.Position = [0.1300    0.1100    0.7750    0.8150];
hax.Color = 'w';


% Create Button
hbut1 = uibutton(hfig, 'Push',...
    'ButtonPushedFcn', @plotDummyData );
hbut1.Position = [35 344 100 22];
hbut1.Text = 'Plot dummay data';

% Create Button2
hbut2 = uibutton(hfig, 'Push',...
    'ButtonPushedFcn', @clearPlot );
hbut2.Position = [35 280 100 22];
hbut2.Text = 'Clear Plot';

% Create Button3
hbut2 = uibutton(hfig, 'Push',...
    'ButtonPushedFcn', @drawLine );
hbut2.Position = [35 216 100 22];
hbut2.Text = 'Draw Line';


end


function clearPlot(varargin)
% Get the handle to figure; 
hfig = findall(0,'Type','figure','tag','FigureStateSpace'); 
hax = findall(hfig,'Type','Axes','tag','StateSpaceAxes'); 
cla(hax);
end
function drawLine(varargin)
hax = findall(0,'Type','Axes','tag','StateSpaceAxes'); 
x = drawline(hax);
x.Tag = 'ThresholdLine';
x.InteractionsAllowed = 'all';
end


