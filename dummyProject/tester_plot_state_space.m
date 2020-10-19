close all; clear all; clc

x = linspace(1,100);
y = linspace(1,100);

for ii=1:length(x)
    plot_state_space(x(ii),y(ii))
    pause(0.1)
end