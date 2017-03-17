//
//  MailMerge.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "MailMerge.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation MailMerge

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)postExecuteTemplate {
    
    NSString *fileName = @"SampleExecuteTemplate.doc";
    [Utils uploadFile:fileName];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleExecuteTemplateData" withExtension:@"txt"];
    
    [self.wordsApi postExecuteTemplateWithCompletionBlock:fileName
                                                     file:pathToFile
                                                  cleanup:nil
                                                 filename:nil
                                                  storage:nil
                                                   folder:nil
                                useWholeParagraphAsRegion:nil
                                              withRegions:nil
                                        completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                            NSLog(@"%@", output);
                                        }];
}

- (void)postDocumentExecuteMailMerge {
    
    NSString *fileName = @"SampleMailMergeTemplateImage.doc";
    [Utils uploadFile:fileName];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleMailMergeTemplateImageData" withExtension:@"txt"];
    
    [self.wordsApi postDocumentExecuteMailMergeWithCompletionBlock:fileName
                                                       withRegions:[NSNumber numberWithBool:NO]
                                                              file:pathToFile
                                                 mailMergeDataFile:nil
                                                           cleanup:nil
                                                          filename:nil
                                                           storage:nil
                                                            folder:nil
                                         useWholeParagraphAsRegion:nil
                                                 completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                     NSLog(@"%@", output);
                                                 }];
}

- (void)putExecuteMailMergeOnline {
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleMailMergeTemplate" withExtension:@"docx"];
    NSURL *pathToDataFile = [[NSBundle mainBundle] URLForResource:@"SampleMailMergeTemplateData" withExtension:@"txt"];
    
    /*cleanup parameter contains list of values from below, separated by ",":
     
     None - without any cleanup
     EmptyParagraphs - Specifies whether paragraphs that contained mail merge fields with no data should be removed from the document
     UnusedRegions - Specifies whether unused mail merge regions should be removed from the document
     UnusedFields - Specifies whether unused merge fields should be removed from the document
     ContainingFields - Specifies whether fields that contain merge fields (for example, IFs) should be removed from the document if the nested merge fields are removed
     RemoveTitleRow - Removes title row of the table if this table doesn't contain any rows except title row.
     RemoveTitleRowInInnerTables - Enable "RemoveTitleRow " for nested tables*/
    
    
    [self.wordsApi putExecuteMailMergeOnlineWithCompletionBlock:[NSNumber numberWithBool:NO]
                                                           file:pathToFile
                                                           data:pathToDataFile
                                                        cleanup:nil
                                              completionHandler:^(NSURL *output, NSError *error) {
                                                  NSLog(@"%@", output);
                                              }];
}

- (void)putExecuteTemplateOnline {
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"SampleExecuteTemplate" withExtension:@"doc"];
    NSURL *pathToDataFile = [[NSBundle mainBundle] URLForResource:@"SampleExecuteTemplateData" withExtension:@"txt"];
    
    [self.wordsApi putExecuteTemplateOnlineWithCompletionBlock:pathToFile
                                                          data:pathToDataFile
                                                       cleanup:nil
                                     useWholeParagraphAsRegion:nil
                                                   withRegions:nil
                                             completionHandler:^(NSURL *output, NSError *error) {
                                                 NSLog(@"%@", output);
                                             }];
}

@end
