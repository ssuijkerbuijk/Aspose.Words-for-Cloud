//
//  Text.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Text.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation Text

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)getDocumentTextItems {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentTextItemsWithCompletionBlock:fileName
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPTextItemsResponse *output, NSError *error) {
                                             NSLog(@"%@", output);
                                         }];
}

- (void)postReplaceText {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPReplaceTextRequest *replaceText = [[ASPReplaceTextRequest alloc] init];
    replaceText.oldValue = @"Times New Roman";
    replaceText.currentValue = @"Arial Black";
    replaceText.isMatchCase = [NSNumber numberWithBool:NO];
    replaceText.isMatchWholeWord = [NSNumber numberWithBool:YES];
    
    [self.wordsApi postReplaceTextWithCompletionBlock:fileName
                                          replaceText:replaceText
                                             filename:nil
                                              storage:nil
                                               folder:nil
                                    completionHandler:^(ASPReplaceTextResponse *output, NSError *error) {
                                        NSLog(@"%@", output);
                                    }];
}

@end
