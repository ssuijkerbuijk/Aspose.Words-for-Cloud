package com.aspose.words.cloud.convert;

import java.io.File;
import java.io.InputStream;




import java.util.ArrayList;

import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentEntry;
import com.aspose.words.model.DocumentEntryList;
import com.aspose.words.model.DocumentResponse;

public class AppendDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: AppendDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set destination file name
			String destFileName = "AppendFile_destination.docx";

			// set source file name
			String sourceFileName = "AppendFile_source.docx";

			DocumentEntryList body = new DocumentEntryList();
			ArrayList<DocumentEntry> docEntries = new ArrayList<DocumentEntry>();

			DocumentEntry docEntry = new DocumentEntry();
			docEntry.setHref(sourceFileName);
			docEntry.setImportFormatMode("KeepSourceFormatting");
			docEntries.add(docEntry);
			body.setDocumentEntries(docEntries);

			File sourceFile = Utils.stream2file("AppendFile_destination","docx", context.getResources().openRawResource(R.raw.AppendWordDocumentsExample_TestFile_Destination));
			File destinationFile = Utils.stream2file("AppendFile_source","docx", context.getResources().openRawResource(R.raw.AppendWordDocumentsExample_TestFile_Source));


			// upload source file to aspose cloud storage
			storageApi.PutCreate(sourceFileName, "", "",
					new File(AppendDocumentExample.class.getResource("/" + sourceFileName).toURI()));

			// upload destination file to aspose cloud storage
			storageApi.PutCreate(destFileName, "", "",
					new File(AppendDocumentExample.class.getResource("/" + destFileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to append word document
			DocumentResponse apiResponse = wordsApi.PostAppendDocument(destFileName, null, null, null, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				System.out.println("Documents have been appended successfully");
				// download appended document from storage server
				com.aspose.storage.model.ResponseMessage storageRes = storageApi.GetDownload(destFileName, null, null);
				InputStream responseStream = storageRes.getInputStream();
				Utils.copyInputStreamToFile(storageRes.getInputStream(),sourceFile);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: AppendDocumentExample

	}

}
