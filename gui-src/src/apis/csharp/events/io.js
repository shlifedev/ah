/* eslint-disable */

const repository = 'io';
const o = () => window[repository]; 
export const io = {
  setController : async (id) => {
    await CefSharp.BindObjectAsync(repository);
    const response = await o().setController(id);
    return response;
  },
  mouseDown : async () => {
    await CefSharp.BindObjectAsync(repository);
    const response = await o().mouseDown(id);
    return response;
  },
  mouseUp : async () => {
    await CefSharp.BindObjectAsync(repository);
    const response = await o().mouseUp(id);
    return response;
  },
  mouseClick : async () => {
    await CefSharp.BindObjectAsync(repository);
    const response = await o().mouseClick(id);
    return response;
  }
}