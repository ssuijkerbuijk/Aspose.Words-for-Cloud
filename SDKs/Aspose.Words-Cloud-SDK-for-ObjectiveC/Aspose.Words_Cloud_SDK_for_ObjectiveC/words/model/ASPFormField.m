#import "ASPFormField.h"

@implementation ASPFormField

/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper
{
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"NodeId": @"nodeId", @"Name": @"name", @"Enabled": @"enabled", @"StatusText": @"statusText", @"OwnStatus": @"ownStatus", @"HelpText": @"helpText", @"OwnHelp": @"ownHelp", @"CalculateOnExit": @"calculateOnExit", @"EntryMacro": @"entryMacro", @"ExitMacro": @"exitMacro", @"link": @"link" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName
{
  NSArray *optionalProperties = @[@"nodeId", @"name", @"enabled", @"statusText", @"ownStatus", @"helpText", @"ownHelp", @"calculateOnExit", @"entryMacro", @"exitMacro", @"link"];

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
