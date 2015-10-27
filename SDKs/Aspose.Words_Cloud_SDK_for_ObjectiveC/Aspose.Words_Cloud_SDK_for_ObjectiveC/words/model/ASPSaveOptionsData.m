#import "ASPSaveOptionsData.h"

@implementation ASPSaveOptionsData

/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper
{
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"SaveFormat": @"saveFormat", @"FileName": @"fileName", @"DmlRenderingMode": @"dmlRenderingMode", @"DmlEffectsRenderingMode": @"dmlEffectsRenderingMode", @"ZipOutput": @"zipOutput" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName
{
  NSArray *optionalProperties = @[@"saveFormat", @"fileName", @"dmlRenderingMode", @"dmlEffectsRenderingMode", @"zipOutput"];

  if ([optionalProperties containsObject:propertyName]) {
    return YES;
  }
  else {
    return NO;
  }
}

/**
 * Gets the string presentation of the object.
 * This method will be called when logging model object using `NSLog`.
 */
- (NSString *)description {
    return [[self toDictionary] description];
}

@end
