export const ValidationConstants = {
  MAX_LENGTH: 255,
    MIN_LENGTH: 1,
    EMAIL_REGEX: /^[^\s@]+@[^\s@]+\.[^\s@]+$/,
    URL_REGEX: /^(https?:\/\/)?([\w-]+(\.[\w-]+)+)(:\d+)?(\/[^\s]*)?$/,
    ALPHANUMERIC_REGEX: /^[a-zA-Z0-9]+$/,
    PHONE_REGEX: /^\+?[1-9]\d{1,14}$/,
    ZIP_CODE_REGEX: /^\d{5}(-\d{4})?$/,
    USERNAME_REGEX: /^[a-zA-Z0-9._-]{3,30}$/,
    PASSWORD_REGEX: /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$/,
    DATE_REGEX: /^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-\d{4}$/,
    TIME_REGEX: /^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9](:[0-5][0-9])?$/
};

export const ErrorMessages = {
  REQUIRED: 'This field is required.',
};

export const SuccessMessages = {
  SUBMISSION_SUCCESS: 'Your submission was successful.',
  DATA_SAVED: 'Data has been saved successfully.',
};

export const InfoMessages = {
  LOADING: 'Loading, please wait...',
  FETCH_SUCCESS: 'Data fetched successfully.',
  UPDATE_SUCCESS: 'Update completed successfully.',
};

export const WarningMessages = {
  UNSAVED_CHANGES: 'You have unsaved changes. Do you want to continue?',
  DEPRECATED_FEATURE: 'This feature is deprecated and may not work as expected.',
};

export const NotificationTypes = {
  ERROR: 'error',
  SUCCESS: 'success',
  INFO: 'info',
  WARNING: 'warning',
};

export const ApiEndpoints = {
  USER_LOGIN: '/api/user/login',
  USER_REGISTER: '/api/user/register',
  FETCH_DATA: '/api/data/fetch',
  UPDATE_DATA: '/api/data/update',
  DELETE_DATA: '/api/data/delete',
};

export const HttpStatusCodes = {
  OK: 200,
  CREATED: 201,
  NO_CONTENT: 204,
  BAD_REQUEST: 400,
  UNAUTHORIZED: 401,
  FORBIDDEN: 403,
  NOT_FOUND: 404,
  INTERNAL_SERVER_ERROR: 500,
};

