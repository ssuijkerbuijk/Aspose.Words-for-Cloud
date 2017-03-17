//
//  Watermark.m
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Watermark.h"
#import "Utils.h"
#import "ASPWordsApi.h"

@implementation Watermark

- (id)init {
    self = [super init];
    
    self.wordsApi = [[ASPWordsApi alloc] init];
    
    return self;
}

- (void)deleteDocumentWatermark {
    
    NSString *fileName = @"SampleBlankWatermarkDocument.docx";
    [Utils uploadFile:fileName];
    
    [self.wordsApi deleteDocumentWatermarkWithCompletionBlock:fileName
                                                     filename:nil
                                                      storage:nil
                                                       folder:nil
                                            completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                NSLog(@"%@", output);
                                            }];
}

- (void)postInsertDocumentWatermarkImage {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    NSString *imageName = @"aspose-cloud.png";
    [Utils uploadFile:imageName];
    
    [self.wordsApi postInsertDocumentWatermarkImageWithCompletionBlock:fileName
                                                              filename:nil
                                                         rotationAngle:[NSNumber numberWithDouble:45]
                                                                 image:@"aspose-cloud.png"
                                                               storage:nil
                                                                folder:nil
                                                     completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                         NSLog(@"%@", output);
                                                     }];
}

- (void)postInsertDocumentWatermarkText {
    
    NSString *fileName = @"SampleWordDocument.docx";
    [Utils uploadFile:fileName];
    
    ASPWatermarkText *watermarkText = [[ASPWatermarkText alloc] init];
    watermarkText.text = @"Welcome Aspose";
    watermarkText.rotationAngle = [NSNumber numberWithDouble:45];
    
    [self.wordsApi postInsertDocumentWatermarkTextWithCompletionBlock:fileName
                                                        watermarkText:watermarkText
                                                             filename:nil
                                                                 text:nil
                                                        rotationAngle:nil
                                                              storage:nil
                                                               folder:nil
                                                    completionHandler:^(ASPDocumentResponse *output, NSError *error) {
                                                        NSLog(@"%@", output);
                                                    }];
}

@end
