export default {
  app: {
    searchNotData: 'No search results yet',
    toSearch: 'to search',
    toNavigate: 'to navigate',
  },
  countdown: {
    normalText: 'Get SMS code',
    sendText: 'Reacquire in {0}s',
  },
  cropper: {
    selectImage: 'Select Image',
    uploadSuccess: 'Uploaded success!',
    modalTitle: 'Avatar upload',
    okText: 'Confirm and upload',
    btn_reset: 'Reset',
    btn_rotate_left: 'Counterclockwise rotation',
    btn_rotate_right: 'Clockwise rotation',
    btn_scale_x: 'Flip horizontal',
    btn_scale_y: 'Flip vertical',
    btn_zoom_in: 'Zoom in',
    btn_zoom_out: 'Zoom out',
    preview: 'Preivew',
  },
  drawer: {
    loadingText: 'Loading...',
    cancelText: 'Close',
    okText: 'Confirm',
  },
  excel: {
    exportModalTitle: 'Export data',
    fileType: 'File type',
    fileName: 'File name',
  },
  form: {
    putAway: 'Put away',
    unfold: 'Unfold',
    maxTip: 'The number of characters should be less than {0}',
    apiSelectNotFound: 'Wait for data loading to complete...',
  },
  icon: {
    placeholder: 'Click the select icon',
    search: 'Search icon',
    copy: 'Copy icon successfully!',
  },
  menu: {
    search: 'Menu search',
  },
  modal: {
    cancelText: 'Close',
    okText: 'Confirm',
    close: 'Close',
    maximize: 'Maximize',
    restore: 'Restore',
  },
  table: {
    settingDens: 'Density',
    settingDensDefault: 'Default',
    settingDensMiddle: 'Middle',
    settingDensSmall: 'Compact',
    settingColumn: 'Column settings',
    settingColumnShow: 'Column display',
    settingIndexColumnShow: 'Index Column',
    settingSelectColumnShow: 'Selection Column',
    settingDragColumnShow: 'Drag Column',
    settingFixedLeft: 'Fixed Left',
    settingFixedRight: 'Fixed Right',
    settingFullScreen: 'Full Screen',
    index: 'Index',
    total: 'total of {total}',
    selectedRows: 'The {count} item has been selected',
    deSelected: 'De Select',
    advancedSearch: {
      title: 'Advanced Search',
      conditions: 'Condition',
      addCondition: 'Add Condition',
      delCondition: 'Del Condition',
      clearCondition: 'Clear Condition',
      field: 'Field',
      logic: 'Logic',
      and: 'And',
      or: 'Or',
      comparison: 'Comparison',
      value: 'Value',
      equal: 'Equal',
      notEqual: 'Not Equal',
      lessThan: 'Less Than',
      lessThanOrEqual: 'less Than Or Equal',
      greaterThan: 'Greater Than',
      greaterThanOrEqual: 'Greater Than Or Equal',
      startsWith: 'Starts With',
      notStartsWith: 'Not Starts With',
      endsWith: 'Ends With',
      notEndsWith: 'Not Ends With',
      contains: 'Contains',
      notContains: 'Not Contains',
      null: 'Null',
      notNull: 'Not Null',
    }
  },
  time: {
    before: ' ago',
    after: ' after',
    just: 'just now',
    seconds: ' seconds',
    minutes: ' minutes',
    hours: ' hours',
    days: ' days',
  },
  tree: {
    selectAll: 'Select All',
    unSelectAll: 'Cancel Select',
    expandAll: 'Expand All',
    unExpandAll: 'Collapse all',

    checkStrictly: 'Hierarchical association',
    checkUnStrictly: 'Hierarchical independence',
  },
  upload: {
    save: 'Save',
    upload: 'Upload',
    imgUpload: 'ImageUpload',
    uploaded: 'Uploaded',

    operating: 'Operating',
    del: 'Delete',
    download: 'download',
    saveWarn: 'Please wait for the file to upload and save!',
    saveError: 'There is no file successfully uploaded and cannot be saved!',

    preview: 'Preview',
    choose: 'Select the file',

    accept: 'Support {0} format',
    acceptUpload: 'Only upload files in {0} format',
    maxSize: 'A single file does not exceed {0}MB ',
    maxSizeMultiple: 'Only upload files up to {0}MB!',
    maxNumber: 'Only upload up to {0} files',

    legend: 'Legend',
    fileName: 'File name',
    fileSize: 'File size',
    fileStatue: 'File status',

    startUpload: 'Start upload',
    uploadSuccess: 'Upload successfully',
    uploadError: 'Upload failed',
    uploading: 'Uploading',
    uploadWait: 'Please wait for the file upload to finish',
    reUploadFailed: 'Re-upload failed files',
  },
  verify: {
    error: 'verification failed!',
    time: 'The verification is successful and it takes {time} seconds!',
    redoTip: 'Click the picture to refresh',
    dragText: 'Hold down the slider and drag',
    successText: 'Verified',
  },
  localizable_input: {
    placeholder: 'Select localized resources',
    resources: {
      fiexed: {
        group: 'Define',
        label: 'Fiexed',
        placeholder: 'Please enter custom content',
      },
      localization: {
        group: 'Localization',
        placeholder: 'Please select a name',
      }
    }
  },
  extra_property_dictionary: {
    title: 'Extra properties',
    key: 'Key',
    value: 'Value',
    actions: {
      title: 'Actions',
      create: 'Add',
      update: 'Edit',
      delete: 'Delete',
      clean: 'Clean',
    },
    validator: {
      duplicateKey: 'A key of the same name has been added',
    },
  },
  value_type_nput: {
    type: {
      name: 'Type',
      FREE_TEXT: {
        name: 'Free Text',
      },
      TOGGLE: {
        name: 'Toggle',
      },
      SELECTION: {
        name: 'Selection',
        displayText: 'Display Text',
        displayTextNotBeEmpty: 'Display text cannot be empty',
        value: 'value',
        duplicateKeyOrValue: 'The name or value of the selection is not allowed to be repeated',
        itemsNotBeEmpty: 'Selectable items cannot be empty',
        itemsNotFound: 'The selection is not included in the optional list',
        actions: {
          title: 'Actions',
          create: 'Add',
          update: 'Edit',
          delete: 'Delete',
          clean: 'Clean',
        },
        modal: {
          title: 'Selection',
        },
      },
    },
    validator: {
      name: 'Validator',
      isInvalidValue: 'The value failed to pass {0}; check the validator options.',
      NULL: {
        name: 'None',
      },
      BOOLEAN: {
        name: 'Boolean',
      },
      NUMERIC: {
        name: 'Numeric',
        minValue: 'Min Value',
        maxValue: 'Max Value',
      },
      STRING: {
        name: 'String',
        allowNull: 'Allow Null',
        minLength: 'Min Length',
        maxLength: 'Max Length',
        regularExpression: 'Regular Expression',
      },
    },
  },
  simple_state_checking: {
    title: 'State checking',
    actions: {
      create: 'Add',
      update: 'Edit',
      delete: 'Delete',
      clean: 'Clean',
    },
    table: {
      name: 'Name',
      properties: 'Properties',
      actions: 'Actions',
    },
    form: {
      name: 'State checking',
    },
    requireAuthenticated: {
      title: 'Require Authenticated',
    },
    requireFeatures: {
      title: 'Require Features',
      requiresAll: 'Requires All',
      requiresAllDesc: 'If checked, all selected features need to be enabled.',
      featureNames: 'Required features',
    },
    requireGlobalFeatures: {
      title: 'Require Global Features',
      featureNames: 'Required Global Features',
    },
    requirePermissions: {
      title: 'Require Permissions',
      requiresAll: 'Requires All',
      requiresAllDesc: 'If checked, you need to have all the selected permissions.',
      permissions: 'Required Permissions',
    },
  }
};
