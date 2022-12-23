 
 import {Menu} from '../components/menu/Menu'
 import {MenuItem} from '../components/menu/MenuItem'
 
import scss from "./Main.module.scss";

const items = [
  {
    name : '매크로',
    view : null,
    icon : 'https://cdn.melvor.net/core/v018/assets/media/skills/attack/attack.svg',
    lock : false
  },
  {
    name : '업무 자동화',
    view : null,
    icon : 'https://cdn.melvor.net/core/v018/assets/media/skills/attack/attack.svg',
    lock : false
  },
  {
    name : '크롤링',
    view : null,
    icon : 'https://cdn.melvor.net/core/v018/assets/media/skills/attack/attack.svg',
    lock : false
  },
  {
    name : '설정',
    view : null,
    icon : 'https://cdn.melvor.net/core/v018/assets/media/skills/attack/attack.svg',
    lock : false
  },  
  {
    name : '설정',
    view : null,
    icon : 'https://cdn.melvor.net/core/v018/assets/media/skills/attack/attack.svg',
    lock : false
  }
]
export const Main = () => {
  return (
    <>
      <div className={scss.content}>
        <Menu>
          <MenuItem></MenuItem>
          <MenuItem></MenuItem>
          <MenuItem></MenuItem>
          <MenuItem></MenuItem>
        </Menu>
      </div>
    </>
  );
};
