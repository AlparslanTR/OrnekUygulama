// ---------------------------------------
// Templates: www.ebenmonney.com/templates
// (c) 2023 www.ebenmonney.com/mit-license
// ---------------------------------------

export class UserLogin {
  constructor(
    public userName = '',
    public password = '',
    public rememberMe?: boolean
  ) { }
}