package com.aspose.words.cloud.fields;

import java.io.File;


import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.FormFieldResponse;

public class InsertFormFieldsWordDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: InsertFormFieldsWordDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleBlankWordDocument.docx";
			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));


			Integer sectionIndex = 0;
			Integer paragraphIndex = 0;
			String insertBeforeNode = "";
			String destFileName = "Updated-" + fileName;
			String storage = "";
			String folder = "";

			String xml = "<FormFieldTextInput>" + "<Name>MyName</Name>" + "<Enabled>true</Enabled>" + "<StatusText />"
					+ "<OwnStatus>false</OwnStatus>" + "<HelpText />" + "<OwnHelp>false</OwnHelp>"
					+ "<CalculateOnExit>true</CalculateOnExit>" + "<EntryMacro />" + "<ExitMacro />"
					+ "<TextInputFormat>UPPERCASE</TextInputFormat>" + "<TextInputType>Regular</TextInputType>"
					+ "<TextInputDefault>Farooq Sheikh</TextInputDefault>" + "</FormFieldTextInput>";

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to add field in the document
			FormFieldResponse apiResponse = wordsApi.PutFormField(fileName, sectionIndex, paragraphIndex,
					insertBeforeNode, destFileName, storage, folder, xml.getBytes("UTF-8"));

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				System.out.println("Form field has been added successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: InsertFormFieldsWordDocumentExample
	}

}
