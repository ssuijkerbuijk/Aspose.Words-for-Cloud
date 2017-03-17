//
//  Fields.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Fields.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation Fields

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)deleteDocumentFields {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi deleteDocumentFieldsWithCompletionBlock:fileName
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                             NSLog(@"%@", output);
                                         }];
}

- (void)deleteFormField {
    
    NSString *fileName = @"FormFilled.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi deleteFormFieldWithCompletionBlock:fileName
                                         sectionIndex:[NSNumber numberWithInt:0]
                                       paragraphIndex:[NSNumber numberWithInt:0]
                                       formfieldIndex:[NSNumber numberWithInt:0]
                                         destFileName:nil
                                              storage:nil
                                               folder:nil
                                    completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                        NSLog(@"%@", output);
                                    }];
}

- (void)deleteSectionFields {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi deleteSectionFieldsWithCompletionBlock:fileName
                                             sectionIndex:[NSNumber numberWithInt:0]
                                                  storage:nil
                                                   folder:nil
                                        completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                            NSLog(@"%@", output);
                                        }];
}

- (void)getFormField {
    
    NSString *fileName = @"FormFilled.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getFormFieldWithCompletionBlock:fileName
                                      sectionIndex:[NSNumber numberWithInt:0]
                                    paragraphIndex:[NSNumber numberWithInt:0]
                                    formfieldIndex:[NSNumber numberWithInt:0]
                                           storage:nil
                                            folder:nil
                                 completionHandler:^(ASPFormFieldResponse *output, NSError *error) {
                                     NSLog(@"%@", output);
                                 }];
}

- (void)postFormField {
    
    NSString *fileName = @"FormFilled.docx";
    [Utils uploadFile:fileName];
    
    ASPFormField *formField = [[ASPFormField alloc] init];
    formField.name = @"CheckBox";
    formField.statusText = @"Helpful?";
    formField.enabled = [NSNumber numberWithBool:YES];
    
    [self.wordsApi postFormFieldWithCompletionBlock:fileName
                                       sectionIndex:[NSNumber numberWithInt:0]
                                     paragraphIndex:[NSNumber numberWithInt:0]
                                     formfieldIndex:[NSNumber numberWithInt:0]
                                          formField:formField
                                       destFileName:nil
                                            storage:nil
                                             folder:nil
                                  completionHandler:^(ASPFormFieldResponse *output, NSError *error) {
                                      NSLog(@"%@", output);
                                  }];
}

- (void)postInsertPageNumbers {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPPageNumber *pagenumber = [[ASPPageNumber alloc] init];
    pagenumber.format = @"{PAGE} of {NUMPAGES}";
    pagenumber.alignment = @"center";
    
    [self.wordsApi postInsertPageNumbersWithCompletionBlock:fileName
                                                 pageNumber:pagenumber
                                                   filename:nil
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
}

- (void)postUpdateDocumentFields {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi postUpdateDocumentFieldsWithCompletionBlock:fileName
                                                      filename:nil
                                                       storage:nil
                                                        folder:nil
                                             completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                 NSLog(@"%@", output);
                                             }];
}

- (void)putFormField {
    
    NSString *fileName = @"FormFilled.docx";
    [Utils uploadFile:fileName];
    
    ASPFormField *formField = [[ASPFormField alloc] init];
    formField.name = @"FullName";
    formField.statusText = @"Enter your name and surname (trimmed to 30 characters)";
    formField.enabled = [NSNumber numberWithBool:YES];
    
    [self.wordsApi putFormFieldWithCompletionBlock:fileName
                                      sectionIndex:[NSNumber numberWithInt:0]
                                    paragraphIndex:[NSNumber numberWithInt:0]
                                         formField:formField
                                  insertBeforeNode:nil
                                      destFileName:nil
                                           storage:nil
                                            folder:nil
                                 completionHandler:^(ASPFormFieldResponse *output, NSError *error) {
                                     NSLog(@"%@", output);
                                 }];
}

@end
