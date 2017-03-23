//
//  SplitResource.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "SplitResource.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation SplitResource

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)splitAllPagesToNewPdfs {
//ExStart:SplitAllPagesToNewPdfs
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi postSplitDocumentWithCompletionBlock:fileName
                                                 format:@"pdf"
                                                   from:nil
                                                     to:nil
                                              zipOutput:[NSNumber numberWithBool:YES]
                                                storage:nil
                                                 folder:nil
                                      completionHandler:^(ASPSplitDocumentResponse *output, NSError *error) {
                                          NSLog(@"%@", output);
                                      }];
//ExEnd:SplitAllPagesToNewPdfs
}

- (void)splitSpecificPagesToAnySupportedFormat {
//ExStart:SplitSpecificPagesToAnySupportedFormat
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi postSplitDocumentWithCompletionBlock:fileName
                                                 format:@"text"
                                                   from:[NSNumber numberWithInt:1]
                                                     to:[NSNumber numberWithInt:2]
                                              zipOutput:[NSNumber numberWithBool:NO]
                                                storage:nil
                                                 folder:nil
                                      completionHandler:^(ASPSplitDocumentResponse *output, NSError *error) {
                                          NSLog(@"%@", output);
                                      }];
//ExEnd:SplitSpecificPagesToAnySupportedFormat
}

- (void)splitSpecificPagesToNewPdfs {
//ExStart:SplitSpecificPagesToNewPdfs
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi postSplitDocumentWithCompletionBlock:fileName
                                                 format:@"pdf"
                                                   from:[NSNumber numberWithInt:1]
                                                     to:[NSNumber numberWithInt:2]
                                              zipOutput:[NSNumber numberWithBool:NO]
                                                storage:nil
                                                 folder:nil
                                      completionHandler:^(ASPSplitDocumentResponse *output, NSError *error) {
                                          NSLog(@"%@", output);
                                      }];
//ExEnd:SplitSpecificPagesToNewPdfs
}

@end
