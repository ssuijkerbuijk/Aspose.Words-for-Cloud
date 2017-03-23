//
//  HeadersAndFooters.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "HeadersAndFooters.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation HeadersAndFooters

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)deleteHeadersFooters {
//ExStart:DeleteHeadersFooters
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi deleteHeadersFootersWithCompletionBlock:fileName
                                       headersFootersTypes:nil
                                                  filename:nil
                                                   storage:nil
                                                    folder:nil
                                         completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                             NSLog(@"%@", output);
                                         }];
//ExEnd:DeleteHeadersFooters
}

@end
