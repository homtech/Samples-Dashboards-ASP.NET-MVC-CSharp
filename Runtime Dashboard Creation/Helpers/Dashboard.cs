﻿using Stimulsoft.Base.Drawing;
using Stimulsoft.Dashboard.Components;
using Stimulsoft.Dashboard.Components.Text;
using Stimulsoft.Report;
using System.Drawing;

namespace Runtime_Dashboard_Creation.Helpers
{
    public class Dashboard
    {
        public static StiReport CreateTemplate()
        {
            var report = new StiReport();
            report.Pages.Clear();

            var dashboard = new StiDashboard();
            report.Pages.Add(dashboard);

            var textElement = new StiTextElement();
            textElement.Left = 100;
            textElement.Top = 100;
            textElement.Width = 300;
            textElement.Height = 100;
            textElement.Text = "Sample Text";
            textElement.Border.Side = StiBorderSides.All;
            textElement.BackColor = Color.LightGray;

            dashboard.Components.Add(textElement);

            return report;
        }
    }
}