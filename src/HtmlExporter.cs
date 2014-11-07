﻿using SharpDox.Model;
using SharpDox.Plugins.Html.Steps;
using SharpDox.Sdk.Exporter;
using SharpDox.Sdk.Local;
using System;
using System.Collections.Generic;
using System.IO;

namespace SharpDox.Plugins.Html
{
    public class HtmlExporter : IExporter
    {
        public event Action<string> OnRequirementsWarning;
        public event Action<string> OnStepMessage;
        public event Action<int> OnStepProgress;

        private double _docCount;
        private double _docIndex;

        private readonly ILocalController _localController;
        private readonly HtmlStrings _htmlStrings;
        private readonly HtmlConfig _htmlConfig;
        
        public HtmlExporter(ILocalController localController, HtmlConfig htmlConfig)
	    {
            _localController = localController;
            _htmlStrings = localController.GetLocalStrings<HtmlStrings>();
            _htmlConfig = htmlConfig;
	    }

        public bool CheckRequirements() { return true; }

        public void Export(SDProject sdProject, string outputPath)
        {
            _docCount = sdProject.DocumentationLanguages.Count;
            _docIndex = 0;
            foreach (var docLanguage in sdProject.DocumentationLanguages)
            {
                StepInput.InitStepinput(sdProject, Path.Combine(outputPath, docLanguage), docLanguage, _localController.GetLocalStringsOrDefault<HtmlStrings>(docLanguage), _htmlStrings, _htmlConfig);

                var steps = new List<StepBase>();
                steps.Add(new PreBuildStep(0, 10));
                steps.Add(new AssetsStep(10, 25));
                steps.Add(new CreateArticleStep(25, 40));
                steps.Add(new CreateHtmlStep(40, 100));

                foreach(var step in steps)
                {
                    ExecuteOnStepProgress(step.StepRange.ProgressStart);

                    step.OnStepMessage += ExecuteOnStepMessage;
                    step.OnStepProgress += ExecuteOnStepProgress;
                    step.RunStep();

                    ExecuteOnStepProgress(step.StepRange.ProgressEnd);
                }

                _docIndex++;
            }
        }

        internal void ExecuteOnStepMessage(string message)
        {
            var handler = OnStepMessage;
            if (handler != null)
            {
                handler(string.Format("({0}) - {1}", StepInput.CurrentLanguage, message));
            }
        }

        internal void ExecuteOnStepProgress(int progress)
        {
            var handler = OnStepProgress;
            if (handler != null)
            {
                handler((int)((progress / _docCount) + (100 / _docCount * _docIndex)));
            }
        }

        public string ExporterName { get { return "Html"; } }
    }
}