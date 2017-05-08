package com.aspose.words.cloud.mailmerge;

import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.DocumentResponse;

public class ExecuteMailMergeWithRegionsExample {

	public static void main(String[] args) {
		// ExStart: ExecuteMailMergeWithRegionsExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleInvoiceTemplate.doc";

			String cleanup = null;
			String destFileName = "updated-" + fileName;
			String mailMergeDataFile = null;
			String storage = null;
			String folder = null;
			Boolean useWholeParagraphAsRegion = false;
			Boolean withRegions = true;
			

			Path p1=Utils.getPath(ExecuteMailMergeWithRegionsExample.class, fileName);

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					p1.toFile());

			// set input file data name
			String fileDataName = "SampleInvoiceTemplateData.txt";
			
			Path p2=Utils.getPath(ExecuteMailMergeWithRegionsExample.class, fileDataName);


			// invoke Aspose.Words Cloud SDK API to execute mail merge and
			// populate a word document from XML data
			DocumentResponse apiResponse = wordsApi.PostDocumentExecuteMailMerge(fileName, withRegions,
					mailMergeDataFile, cleanup, destFileName, storage, folder, useWholeParagraphAsRegion, p2.toFile());

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("mail merge template has been executed successfully");

				// download updated file from cloud storage
				com.aspose.storage.model.ResponseMessage storageRes = storageApi.GetDownload(destFileName, null, null);

				InputStream responseStream = storageRes.getInputStream();

				final Path destination = Paths.get("./" + destFileName);

				Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ExecuteMailMergeWithRegionsExample
	}

}
