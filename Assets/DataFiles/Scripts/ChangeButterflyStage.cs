using UnityEngine;
using TMPro;

public class ChangeButterflyStage : MonoBehaviour
{
    public GameObject panel;
    public TMP_Text titleTextObj;
    public TMP_Text nameTextObj;
    public TMP_Text contentTextObj;

    public void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        panel.SetActive(true);
        if (gameObject.name == "ButterflySphereCollider")
        {
            titleTextObj.text = "Stage 4";
            nameTextObj.text = "Butterfly";
            contentTextObj.text = "The adult butterfly emerges from the chrysalis with its soft wings folded about its body. After a rest period, the butterfly pumps blood into its wings and begins to fly.";
        } else if (gameObject.name == "PupaSphereCollider")
        {
            titleTextObj.text = "Stage 3";
            nameTextObj.text = "Pupa";
            contentTextObj.text = "When the caterpillar reaches full size, they form into a “chrysalis” or “pupa.” Inside, they are undergoing a transformation or “metamorphosis.” The parts we recognize as a butterfly are beginning to form.";
        } else if (gameObject.name == "EggSphereCollider")
        {
            titleTextObj.text = "Stage 1";
            nameTextObj.text = "Egg";
            contentTextObj.text = "The first stage of a butterfly’s life is a very small oval, round, or cylindrical egg, depending on the species of butterfly.";
        } else if (gameObject.name == "CaterpillarSphereCollider")
        {
            titleTextObj.text = "Stage 2";
            nameTextObj.text = "Larva";
            contentTextObj.text = "When the egg hatches, a “larva” or “caterpillar” emerges. Caterpillars must grow quickly, so they eat continually.";
        }
    }
}
