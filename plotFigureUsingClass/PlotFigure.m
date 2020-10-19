classdef PlotFigure
    properties
        Value {mustBeNonNan}
        hfig % handle to figure 
        hax % handle to axes 
        hbut1 % handle to button 1 
        hbut2 % handle to button 2 
        
        xvals {mustBeNumeric}
        yvals {mustBeNumeric}
    end
    methods
        function obj = PlotFigure(varargin)
            %  setup up figure
            hfig = uifigure();
            hfig.Color = 'w';
            % set up axis
            hax = axes('Parent',hfig);
            title(hax, 'Title')
            xlabel(hax, 'X')
            ylabel(hax, 'Y')
            hax.Position = [0.1300    0.1100    0.7750    0.8150];
            hax.Color = 'w';
%             hax.BackgroundColor = 'w';
            obj.hax = hax; 
            
            % Create Button
            hbut1 = uibutton(hfig, 'Push',...
                'ButtonPushedFcn', @obj.plotDummyData );
            hbut1.Position = [35 344 100 22];
            hbut1.Text = 'Plot dummay data';
            
            
            % Create Button2
            hbut2 = uibutton(hfig, 'Push',...
                'ButtonPushedFcn', @obj.clearPlot );
            hbut2.Position = [35 280 100 22];
            hbut2.Text = 'Clear Plot';
            
            % Create Button3
            hbut2 = uibutton(hfig, 'Push',...
                'ButtonPushedFcn', @obj.drawLine );
            hbut2.Position = [35 216 100 22];
            hbut2.Text = 'Draw Line';
            
            
            % initialize some values and plot on startup 
            if nargin == 0 
                obj.xvals = randperm(10,10);
                obj.yvals = randperm(10,10);
                obj.PlotData(obj.xvals,obj.yvals,obj);
            end
            if nargin == 2 
                obj.xvals = varargin{1};
                obj.yvals = varargin{2};
            end
        end
        function PlotData(varargin)
            obj = varargin{1};
            x = varargin{2};
            y = varargin{3};
            hold(obj.hax,'on');
            scatter(x,y,...
                100,'filled',...
                'MarkerFaceColor',[0.8 0 0],...
                'MarkerFaceAlpha',0.5,...
                'Parent',obj.hax);
        end
        function plotDummyData(varargin)
            obj = varargin{1};
            cla(obj.hax);
            hold(obj.hax,'on');
            obj.xvals = randperm(10,10);
            obj.yvals = randperm(10,10);
            obj.PlotData(obj.xvals,obj.yvals);

        end
        function clearPlot(varargin)
            obj = varargin{1};
            cla(obj.hax);
        end
        function drawLine(varargin)
            obj = varargin{1};
            x = drawline(obj.hax);
        end

    end
end
