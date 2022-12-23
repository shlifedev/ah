import scss from "./Menu.module.scss";
export const Menu = (props) =>{
  return <aside className={scss.menu}>
    <ul>
      {props.children}
    </ul>
  </aside>
}