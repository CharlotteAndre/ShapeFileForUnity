using System.Collections;
using System.Collections.Generic;
using System.IO; 
using UnityEngine;
using Assets.PipelineGenerator.Scripts.ESRI.ShapeImporter25D;


public class ShapefileImport : MonoBehaviour
{
    //Le string du path, a modifier pour qu'il soit automatique en drag and drop

    //La lecture du fichier binaire et stockage dans un tableau de byte

    //Il faut voir ce qui est dedans, trier l'en-tête et les valeurs...

    public string path;

    void Start()
    {
        ShapeFile shapeFile = new ShapeFile();
        shapeFile.Read(path);
        Debug.Log(shapeFile.ToString());
        List<Vector3> vertices = new List<Vector3>();
        foreach (ShapeFileRecord record in shapeFile.Records)
        {
            foreach (Vector3 point in record.Points)
            {
                vertices.Add(point);
                Debug.Log(point);

            }
            foreach (Vector3 point in vertices)
            {
                Debug.Log(point);
            }
        }
        

    }
    //void CreateSelection(IEnumerable<Vector3> points)
    //{
    //    selection = new GameObject("Selection");
    //    MeshFilter meshFilter = (MeshFilter)selection.AddComponent(typeof(MeshFilter));

    //    meshFilter.mesh = CreateMesh(points);

    //    MeshRenderer renderer = selection.AddComponent(typeof(MeshRenderer)) as MeshRenderer;
    //    //renderer.material.shader = Shader.Find("Particles/Additive");
    //    Texture2D tex = new Texture2D(1, 1);
    //    tex.SetPixel(0, 0, Color.green);
    //    tex.Apply();
    //    renderer.material.mainTexture = tex;
    //    renderer.material.color = Color.green;
    //}

    //Mesh CreateMesh(IEnumerable<Vector3> stars)
    //{
    //    Mesh m = new Mesh();
    //    m.name = "ScriptedMesh";
    //    List<int> triangles = new List<int>();

    //    var vertices = stars.Select(x => new Vertex(x)).ToList();

    //    var result = MIConvexHull.ConvexHull.Create(vertices);
    //    m.vertices = result.Points.Select(x => x.ToVec()).ToArray();
    //    var xxx = result.Points.ToList();

    //    foreach (var face in result.Faces)
    //    {
    //        triangles.Add(xxx.IndexOf(face.Vertices[0]));
    //        triangles.Add(xxx.IndexOf(face.Vertices[1]));
    //        triangles.Add(xxx.IndexOf(face.Vertices[2]));
    //    }

    //    m.triangles = triangles.ToArray();
    //    m.RecalculateNormals();
    //    return m;
    //}

}