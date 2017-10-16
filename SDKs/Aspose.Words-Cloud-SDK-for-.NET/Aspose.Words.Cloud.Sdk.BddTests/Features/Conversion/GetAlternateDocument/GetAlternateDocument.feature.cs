﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.GetAlternateDocument
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class StoredDocumentConversionWithReturnResultInResponseFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetAlternateDocument.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Stored document conversion with return result in response", "In order to reuse document content for various purposes (such as read-only PDF di" +
                    "stribution)\r\nA user should be able to convert Word document to different formats" +
                    "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Stored document conversion with return result in response")))
            {
                Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.GetAlternateDocument.StoredDocumentConversionWithReturnResultInResponseFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void ConversionOfStoredDocument(string docName, string destFormat, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ConversionOfStoredDoc"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conversion of stored document", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("I have uploaded document with name {0} to storage", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("I have specified format {0} document to be converted", destFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And(string.Format("I have specified document name {0} in URL", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I execute conversion from storage (GET document with format)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("document is returned as an attachment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.And(string.Format("attachment\'s format is {0}", destFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        public virtual void ConversionOfStoredDocument_Variant0()
        {
            this.ConversionOfStoredDocument("TableDocument.doc", "pdf", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        public virtual void ConversionOfStoredDocument_Variant1()
        {
            this.ConversionOfStoredDocument("test_doc.docx", "pdf", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "png")]
        public virtual void ConversionOfStoredDocument_Variant2()
        {
            this.ConversionOfStoredDocument("test_doc.docx", "png", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        public virtual void ConversionOfStoredDocument_Variant3()
        {
            this.ConversionOfStoredDocument("test_doc.docx", "html", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        public virtual void ConversionOfStoredDocument_Variant4()
        {
            this.ConversionOfStoredDocument("TableDocument.doc", "html", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "txt")]
        public virtual void ConversionOfStoredDocument_Variant5()
        {
            this.ConversionOfStoredDocument("TableDocument.doc", "txt", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "htmlfixed")]
        public virtual void ConversionOfStoredDocument_Variant6()
        {
            this.ConversionOfStoredDocument("TableDocument.doc", "htmlfixed", ((string[])(null)));
        }
        
        public virtual void ConversionOfStoredDocumentAndSaveToStorage(string docName, string destFormat, string outPath, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ConversionOfStoredDoc"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conversion of stored document and save to storage", @__tags);
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given(string.Format("I have uploaded document with name {0} to storage", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.And(string.Format("I have specified format {0} document to be converted", destFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And(string.Format("I have specified output path {0}", outPath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And(string.Format("I have specified document name {0} in URL", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("I execute conversion from storage (GET document with format)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("converted document downloads from storage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/getalternate/TableDocument.pdf")]
        public virtual void ConversionOfStoredDocumentAndSaveToStorage_Variant0()
        {
            this.ConversionOfStoredDocumentAndSaveToStorage("TableDocument.doc", "pdf", "out/getalternate/TableDocument.pdf", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/getalternate/test_doc.pdf")]
        public virtual void ConversionOfStoredDocumentAndSaveToStorage_Variant1()
        {
            this.ConversionOfStoredDocumentAndSaveToStorage("test_doc.docx", "pdf", "out/getalternate/test_doc.pdf", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "png")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/getalternate/test_doc.png")]
        public virtual void ConversionOfStoredDocumentAndSaveToStorage_Variant2()
        {
            this.ConversionOfStoredDocumentAndSaveToStorage("test_doc.docx", "png", "out/getalternate/test_doc.png", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/getalternate/test_doc.html")]
        public virtual void ConversionOfStoredDocumentAndSaveToStorage_Variant3()
        {
            this.ConversionOfStoredDocumentAndSaveToStorage("test_doc.docx", "html", "out/getalternate/test_doc.html", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/getalternate/TableDocument.html")]
        public virtual void ConversionOfStoredDocumentAndSaveToStorage_Variant4()
        {
            this.ConversionOfStoredDocumentAndSaveToStorage("TableDocument.doc", "html", "out/getalternate/TableDocument.html", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "txt")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/getalternate/TableDocument.txt")]
        public virtual void ConversionOfStoredDocumentAndSaveToStorage_Variant5()
        {
            this.ConversionOfStoredDocumentAndSaveToStorage("TableDocument.doc", "txt", "out/getalternate/TableDocument.txt", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion of stored document and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with return result in response")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionOfStoredDoc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "htmlfixed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/getalternate/TableDocument.htmlfixed")]
        public virtual void ConversionOfStoredDocumentAndSaveToStorage_Variant6()
        {
            this.ConversionOfStoredDocumentAndSaveToStorage("TableDocument.doc", "htmlfixed", "out/getalternate/TableDocument.htmlfixed", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
