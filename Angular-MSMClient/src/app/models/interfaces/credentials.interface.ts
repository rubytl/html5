export interface Credentials {
    username: string;
    password: string;
}

export interface ResetCredentials extends Credentials {
    newPassword: string;
    confirmNewPassword: string;
    email: string;
}