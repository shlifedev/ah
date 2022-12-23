/* eslint-disable */

const repository = 'messageBox';
const o = () => window[repository]; 
export const messageBox = {
    show : async (text) => {
      await CefSharp.BindObjectAsync(repository);
      const response = await o.show(text);
      return response;
    }
}