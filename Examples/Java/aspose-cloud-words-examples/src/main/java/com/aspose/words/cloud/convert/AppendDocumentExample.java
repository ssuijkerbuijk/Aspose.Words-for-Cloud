package com.aspose.words.cloud.convert;

import java.io.File;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;
import java.util.ArrayList;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentEntry;
import com.aspose.words.model.DocumentEntryList;
import com.aspose.words.model.DocumentResponse;

public class AppendDocumentExample {

	public static void main(String[] args) {

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
				final Path destination = Paths.get(sourceFileName);
				Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}

	}

}
