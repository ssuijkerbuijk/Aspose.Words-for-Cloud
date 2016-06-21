#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using csUnit;
using Com.Aspose.Words.Api;
using System.Text.RegularExpressions;
using Com.Aspose.Words;
using Com.Aspose.Words.Model;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2015 (c) by Com All Rights Reserved.
//  
// Project:      Aspose
// Module:       WordsApiTest.cs
// Description:  Tests for the Words Api class in the Console Application assembly.
//  
// Date:       Author:           Comments:
// 11/20/2015 12:14 PM  imran     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace Com.Aspose.Words.ApiTest
{

    /// <summary>
    /// Tests for the Words Api Class
    /// Documentation: 
    /// </summary>
    [TestFixture]
    public class WordsApiTest
    {
        #region Class Variables
        private WordsApi _wordsApi;
        #endregion

        #region Setup/Teardown

        /// <summary>
        /// Code that is run before each test
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            //New instance of Words Api
            _wordsApi = new WordsApi();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _wordsApi or delete this line
        }
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        // No methods were found. No tests are generated for methods.

        #endregion // End of GeneratedMethods

        #endregion

    }
}
