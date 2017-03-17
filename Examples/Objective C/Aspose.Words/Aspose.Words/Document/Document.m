//
//  Document.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 16/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Document.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation Document

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)testAcceptAllRevisions {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi acceptAllRevisionsWithCompletionBlock:fileName
                                                filename:nil
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPRevisionsModificationResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
}

- (void)deleteDocumentMacros {
    
    NSString *fileName = @"Test.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi deleteDocumentMacrosWithCompletionBlock:fileName
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                             NSLog(@"%@", output);
                                         }];
}

- (void)getDocument {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentWithCompletionBlock:fileName
                                          storage:nil
                                           folder:nil
                                completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                    NSLog(@"%@", output);
                                }];
}

- (void)getDocumentStatistics {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentStatisticsWithCompletionBlock:fileName
                                            includeComments:[NSNumber numberWithBool:YES]
                                           includeFootnotes:[NSNumber numberWithBool:YES]
                                        includeTextInShapes:[NSNumber numberWithBool:YES]
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPStatDataResponse *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
}

- (void)getDocumentWithFormat {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentWithFormatWithCompletionBlock:fileName
                                                     format:@"pdf"
                                                    storage:nil
                                                     folder:nil
                                                    outPath:nil
                                          completionHandler:^(NSURL *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
}

- (void)postAppendDocument {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPDocumentEntry *document1 = [[ASPDocumentEntry alloc] init];
    document1.href = @"SampleAppendDoc.docx";
    document1.importFormatMode = @"KeepSourceFormatting";
    
    ASPDocumentEntry *document2 = [[ASPDocumentEntry alloc] init];
    document2.href = @"SampleAppendDoc2.docx";
    document2.importFormatMode = @"KeepSourceFormatting";
    
    ASPDocumentEntryList *documentList = [[ASPDocumentEntryList alloc] init];
    documentList.documentEntries = (NSArray<ASPDocumentEntry>*) @[document1, document2];
    
    
    [self.wordsApi postAppendDocumentWithCompletionBlock:fileName
                                            documentList:documentList
                                                filename:nil
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
}

- (void)postDocumentSaveAs {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPSaveOptionsData *saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.fileName = @"SampleWordDocument.pdf";
    saveOptions.saveFormat = @"pdf";
    
    [self.wordsApi postDocumentSaveAsWithCompletionBlock:fileName
                                         saveOptionsData:saveOptions
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
}

- (void)postLoadWebDocument {
    
    ASPLoadWebDocumentData *loadWebDocumentData = [[ASPLoadWebDocumentData alloc] init];
    loadWebDocumentData.loadingDocumentUrl = @"http://google.com";
    
    ASPSaveOptionsData *saveOptions = [[ASPSaveOptionsData alloc] init];
    saveOptions.saveFormat = @"doc";
    saveOptions.fileName = @"google.doc";
    
    loadWebDocumentData.saveOptions = saveOptions;
    
    [self.wordsApi postLoadWebDocumentWithCompletionBlock:loadWebDocumentData completionHandler:^(ASPSaveResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
}

- (void)postRunTask {
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleWordDocument" withExtension:@"docx"];
    
    [self.wordsApi postRunTaskWithCompletionBlock:pathToFile completionHandler:^(ASPResponseMessage *output, NSError *error) {
        NSLog(@"%@", output);
    }];
}

- (void)putConvertDocument {
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleWordDocument" withExtension:@"docx"];
    
    [self.wordsApi putConvertDocumentWithCompletionBlock:pathToFile
                                                  format:@"pdf"
                                                 outPath:nil
                                  replaceResourcesHostTo:nil
                                       completionHandler:^(NSURL *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
}

- (void)putDocumentSaveAsTiff {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPTiffSaveOptionsData *tiffSaveOptions = [[ASPTiffSaveOptionsData alloc] init];
    tiffSaveOptions.fileName = @"SampleWordDocument.tiff";
    tiffSaveOptions.saveFormat = @"tiff";
    
    [self.wordsApi putDocumentSaveAsTiffWithCompletionBlock:fileName
                                                saveOptions:tiffSaveOptions
                                                 resultFile:nil
                                            useAntiAliasing:nil
                                    useHighQualityRendering:nil
                                            imageBrightness:nil
                                             imageColorMode:nil
                                              imageContrast:nil
                                              numeralFormat:nil
                                                  pageCount:nil
                                                  pageIndex:nil
                                                 paperColor:nil
                                                pixelFormat:nil
                                                 resolution:nil
                                                      scale:nil
                                            tiffCompression:nil
                                           dmlRenderingMode:nil
                                    dmlEffectsRenderingMode:nil
                                     tiffBinarizationMethod:nil
                                                    storage:nil
                                                     folder:nil
                                                  zipOutput:nil
                                          completionHandler:^(ASPSaveResponse *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
}

- (void)testRejectAllRevisions {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi rejectAllRevisionsWithCompletionBlock:fileName
                                                filename:nil
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(ASPRevisionsModificationResponse *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
}

@end
