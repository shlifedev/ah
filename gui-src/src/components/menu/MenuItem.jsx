import scss from "./MenuItem.module.scss";
export const MenuItem = (props) => {
  return (
    <li>
      <a href={props.href}>
        <div className={scss.itemWrapper}>
          <div className={scss.itemContainer}>
            <div className={scss.subject}>
              <img
                src="https://cdn.melvor.net/core/v018/assets/media/skills/attack/attack.svg"
                alt="icon"
              />
              <p className={scss.name}>매크로</p>
            </div>
            <div className={scss.subinfo}>(잠금)</div>
          </div>
        </div>
      </a>
    </li>
  );
};
