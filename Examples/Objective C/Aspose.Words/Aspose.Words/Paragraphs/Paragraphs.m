//
//  Paragraphs.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Paragraphs.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation Paragraphs

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)deleteParagraphFields {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi deleteParagraphFieldsWithCompletionBlock:fileName
                                                      index:[NSNumber numberWithInt:0]
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
}

- (void)getDocumentParagraph {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentParagraphWithCompletionBlock:fileName
                                                     index:[NSNumber numberWithInt:1]
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPParagraphResponse *output, NSError *error) {
                                             NSLog(@"%@", output);
                                         }];
}

- (void)getDocumentParagraphRun {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentParagraphRunWithCompletionBlock:fileName
                                                        index:[NSNumber numberWithInt:0]
                                                     runIndex:[NSNumber numberWithInt:0]
                                                      storage:nil
                                                       folder:nil
                                            completionHandler:^(ASPRunResponse *output, NSError *error) {
                                                NSLog(@"%@", output);
                                            }];
}

- (void)getDocumentParagraphRunFont {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentParagraphRunFontWithCompletionBlock:fileName
                                                            index:[NSNumber numberWithInt:0]
                                                         runIndex:[NSNumber numberWithInt:0]
                                                          storage:nil
                                                           folder:nil
                                                completionHandler:^(ASPFontResponse *output, NSError *error) {
                                                    NSLog(@"%@", output);
                                                }];
}

- (void)getDocumentParagraphs {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentParagraphsWithCompletionBlock:fileName
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPParagraphLinkCollectionResponse *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
}

- (void)postDocumentParagraphRunFont {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPFont *font = [[ASPFont alloc] init];
    font.name = @"Arial";
    font.bold = [NSNumber numberWithBool:YES];
    
    [self.wordsApi postDocumentParagraphRunFontWithCompletionBlock:fileName
                                                             index:[NSNumber numberWithInt:0]
                                                          runIndex:[NSNumber numberWithInt:0]
                                                              font:font
                                                           storage:nil
                                                            folder:nil
                                                          filename:nil
                                                 completionHandler:^(ASPFontResponse *output, NSError *error) {
                                                     NSLog(@"%@", output);
                                                 }];
}


@end
