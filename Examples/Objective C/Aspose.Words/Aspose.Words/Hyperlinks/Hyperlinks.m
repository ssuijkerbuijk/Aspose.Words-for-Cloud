//
//  Hyperlinks.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Hyperlinks.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation Hyperlinks

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)getDocumentHyperlinkByIndex {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentHyperlinkByIndexWithCompletionBlock:fileName
                                                   hyperlinkIndex:[NSNumber numberWithInt:0]
                                                          storage:nil
                                                           folder:nil
                                                completionHandler:^(ASPHyperlinkResponse *output, NSError *error) {
                                                    NSLog(@"%@", output);
                                                }];
}

- (void)getDocumentHyperlinks {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi getDocumentHyperlinksWithCompletionBlock:fileName
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(ASPHyperlinksResponse *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
}

@end
