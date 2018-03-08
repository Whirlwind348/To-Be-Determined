// Created by Crowbar 0.55

$modelname "fluxmage/Zim1_1.mdl"

$bodygroup "studio"
{
	studio "Zim1_1.smd"
}


$surfaceprop "alienflesh"

$contents "solid"

$illumposition 0 -0.331 40.731

$cdmaterials "models\fluxmage\Zim\"

$cbox 0 0 0 0 0 0

$bbox -14.665 -12.506 -0.397 17.258 12.506 45.133

$definebone "b1" "" 0 0.561954 10.348146 -88.636001 90.000037 -89.999928 0 0 0 0 0 0
$definebone "b2" "b1" 2.716284 0 0 0 6.276409 -0.000057 0 0 0 0 0 0
$definebone "ra1" "b2" 4.245377 0.277782 2.238 89.514227 -7.638158 -89.99792 0 0 0 0 0 0
$definebone "ra2" "ra1" -2.996922 0.000001 0 -1.450615 0.134015 0.000001 0 0 0 0 0 0
$definebone "rh" "ra2" -3.884634 -0.010542 0 0 3.364122 0.000001 0 0 0 0 0 0
$definebone "la1" "b2" 4.245377 0.277782 -2.23959 89.514206 172.357899 -90.001677 0 0 0 0 0 0
$definebone "la2" "la1" 2.996922 0 0 -1.450615 0.134015 0 0 0 0 0 0 0
$definebone "lh" "la2" 3.884634 0.010543 0 0 3.364122 0 0 0 0 0 0 0
$definebone "h" "b2" 6.162005 -0.258348 0 0 -38.441855 0 0 0 0 0 0 0
$definebone "h2" "h" 17.840931 4.955125 0 0 91.746872 0 0 0 0 0 0 0
$definebone "rl1" "b1" -1.311144 -0.268062 1.932798 0 179.706855 0.000115 0 0 0 0 0 0
$definebone "rl2" "rl1" 3.813983 0.05976 0 0 -3.084289 0 0 0 0 0 0 0
$definebone "rf" "rl2" 4.400556 0.01539 0 0 -8.477999 0 0 0 0 0 0 0
$definebone "ll1" "b1" -1.311145 -0.268068 -1.932 0 -0.293125 0 0 0 0 0 0 0
$definebone "ll2" "ll1" -3.813984 -0.05976 0 0 -3.084289 0 0 0 0 0 0 0
$definebone "lf" "ll2" -4.400556 -0.01539 0 0 -8.477999 0 0 0 0 0 0 0


$sequence "ragdoll" {
	"zim1_1_anims\ragdoll.smd"
	activity "ACT_DIERAGDOLL" 1
	fadein 0.2
	fadeout 0.2
	fps 30
}

$collisionjoints "zim1_1_physics.smd"
{
	$mass 50
	$inertia 1
	$damping 0
	$rotdamping 0
	$rootbone "b1"


	$jointconstrain "ll1" x limit 0 0 0
	$jointconstrain "ll1" y limit -30 20 0
	$jointconstrain "ll1" z limit -30 75 0

	$jointconstrain "ll2" x limit 0 0 0
	$jointconstrain "ll2" y limit 0 0 0
	$jointconstrain "ll2" z limit -140 0 0

	$jointconstrain "rl1" x limit 0 0 0
	$jointconstrain "rl1" y limit -30 20 0
	$jointconstrain "rl1" z limit -30 75 0

	$jointconstrain "rl2" x limit 0 0 0
	$jointconstrain "rl2" y limit 0 0 0
	$jointconstrain "rl2" z limit -140 0 0

	$jointconstrain "rf" x limit -20 20 0
	$jointconstrain "rf" y limit -15 15 0
	$jointconstrain "rf" z limit -60 40 0

	$jointconstrain "b2" x limit -35 35 0
	$jointconstrain "b2" y limit 0 0 0
	$jointconstrain "b2" z limit 0 0 0

	$jointconstrain "h" x limit -40 40 0
	$jointconstrain "h" y limit -35 35 0
	$jointconstrain "h" z limit -40 30 0

	$jointconstrain "la1" x limit 0 0 0
	$jointconstrain "la1" y limit -100 50 0
	$jointconstrain "la1" z limit -140 60 0

	$jointconstrain "la2" x limit 0 0 0
	$jointconstrain "la2" y limit -140 0 0
	$jointconstrain "la2" z limit 0 0 0

	$jointconstrain "h2" x limit 0 0 0
	$jointconstrain "h2" y limit 0 0 0
	$jointconstrain "h2" z limit -20 30 0

	$jointconstrain "ra1" x limit 0 0 0
	$jointconstrain "ra1" y limit -100 50 0
	$jointconstrain "ra1" z limit -140 60 0

	$jointconstrain "ra2" x limit 0 0 0
	$jointconstrain "ra2" y limit -140 0 0
	$jointconstrain "ra2" z limit 0 0 0

	$jointconstrain "rh" x limit -90 60 0
	$jointconstrain "rh" y limit -25 25 0
	$jointconstrain "rh" z limit -60 60 0

	$jointconstrain "lh" x limit -90 60 0
	$jointconstrain "lh" y limit -25 25 0
	$jointconstrain "lh" z limit -60 60 0

	$jointconstrain "lf" x limit -20 20 0
	$jointconstrain "lf" y limit -15 15 0
	$jointconstrain "lf" z limit -60 40 0
}
